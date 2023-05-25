using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Theatre
{
    
    abstract class Information
    {
        public string ball { get; set; } 
        public uint ID { get; set; } 
    }
    
    class Ev : Information
    {
        public string name { get; set; }
        public string concert_spectacl { get; set; }
        public uint n_actors { get; set; }
        public uint n_ticks { get; set; }
        public uint money { get; set; }
        
        public Ev(string name_ev, string conc_spect, uint n_ac, uint n_tick, uint price, string balls,uint id)
        {
            name = name_ev;
            concert_spectacl = conc_spect;
            n_actors = n_ac;
            n_ticks = n_tick;
            money = price;
            ball = balls;
            ID = id;
        }
    }
    
    class Ac : Information
    {
        public string name { get; set; }
        public uint years { get; set; }
        public uint years_work { get; set; }
        
        public Ac(string act, uint age, uint y_work, string balls,uint id)
        {
            name = act;
            years = age;
            years_work = y_work;
            ball = balls;
            ID = id;
        }
    }

}