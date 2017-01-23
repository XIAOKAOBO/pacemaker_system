#include "mbed.h"
#include "rtos.h"
#include "motion.h"
#include "pinmap.h"
#include "pulsegenerator.h"
#include "parameters.h"
//#include "pulsegenerator.cpp"

// main() runs in its own thread in the OS
// (note the calls to Thread::wait below for delays)


volatile int modeID, requestData, Switch, display;
volatile int trigger;
float magtd;
int a ;
int b ;
volatile int inter;
InterruptIn sw(SW3);
DigitalOut atrialPacing(LED2);
DigitalOut bothPacing(LED1,LED2);
DigitalOut ventricuPacing(LED1);

//AnalogOut ventri(PTB2);

Serial poi(USBTX,USBRX);



class PaceModule{
    public:
        volatile int oamp,orate;
        volatile float rate,amp;
    public:
        void pace(bool p_hysteresis, int hypdelay, int modeNum, AnalogOut chamber, float width,float amplitude,int interval );
        void transmit(int sel);

        
};

 void setup(void) {
    setPins();
    pulsegenerator_initialize ();
 }



/*
void PaceModule::PaceModule::modeC(int modeNum){
    if(SW3==true){       
        if(modeID==modeNum){
            modeID=2;   
            requestData = 0;
        }else{
            modeID=1;    
            requestData = 1;
        }         
    }else{
        modeID = modeID;    
    }    
}
*/


 void changeSwitch(){

        if(Switch==1){
            Switch=0;
                
        }else{
            Switch =1;
        }
}


void PaceModule::transmit(int sel ){
        
        if(sel==1){
          poi.printf("\nrate:%f amplitude:%f Sensing Magintude: %f\n",rate,amp,magtd);       
        }
    
    }
    
    /*
void PaceModule::pace(bool p_hysteresis,int hypdelay, int modeNum,AnalogOut chamber, float width,float amplitude,int interval){
    
    
    //rate = 1000/(width+interval);
    //amp = amplitude;
    
    bool hysteresis = p_hysteresis;
    while(Switch == 1){
        

    if(hysteresis){
        if((hypdelay>500)||(hypdelay<200)){
                Thread::wait(300);
        }else{
                Thread::wait(hypdelay);
            }
            p_hysteresis = false;
        }
        
        
        if(chamber == bothPacing){
            // as more and more specs are provided we can change parameters for future pacing of two chambers.
            ventricuPacing=0;
            atrialPacing = 1;
            Thread::wait(width*a);
            ventricuPacing=1;
            atrialPacing = 0;;
            Thread::wait(width*b);
            atrialPacing = 0;
            ventricuPacing=0;
            Thread::wait(interval);
        }else{
           // for this assignment we only need to output digital 1 and 0 rather than voltage, these would be implemented in future assignments
           chamber.write(amplitude/3.3); 
            if((width<1.9)||(width>0.1)){
                Thread::wait(0.4);
            }else{
                Thread::wait(width);
            }
            chamber.write(0);
            Thread::wait(interval);                
            if((width<343)||(width>2000)){
                
                Thread::wait(1000);
            }else{
                Thread::wait(interval);
            }
        }    
    }
    
}
*/

void thePace(PaceModule a){
    
       a.amp = get_vent_pulse_amp();
       a.rate = 1000/(get_vent_pulse_width_us()+160);

       if(poi.readable()){
           trigger = int(poi.getc());
           if(trigger==1){
               Switch=1;
            }else if(trigger ==0){
               Switch=0;     
            }else if(trigger== 2){
                modeID = 0;
            }else if(trigger == 3){
                modeID = 1; 
            }else if(trigger == 4){
                if(display==0)
                {
                    display=1;
                }else
                {
                    display=0;
                }
            }              
        }
        
        if(display==1){
            a.transmit(Switch);
        }
        
        if(Switch==1){
            if(modeID==0)
            {
               atrialPacing=1;
               pace_VOOR();
               atrialPacing=0;
            }else if(modeID==1){
               ventricuPacing=1;
               pace_VOO();
               ventricuPacing=0;
            }
        }
}



int main(){
    
    Switch = 1;
    requestData = 1;
    modeID = 1;
    display=1;
    modeID =0;
    poi.baud(9600);
    PaceModule pc;
    
    setup();
    
    
    Thread motionThread(osPriorityNormal);
    initialize_motion ();
    motionThread.start(motion_thread);
    
    begin_pace();
    
    while(true){

         thePace(pc);
         sw.rise(&changeSwitch);
    }
   
}
