using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BoClass
    {
        DalClass d = new DalClass();
        Graphics gg;
        public int x = 465;
        public int y = 26;
        public char key = 'r';
        public bool saveSpeed(Car c)
        {
            return d.save(Convert.ToString(c.speed));
        }
        public int speedCalculation()
        {
            Car c = d.getData();
            if (c.speed == 10)
                return 1000;
            else if (c.speed == 20)
                return 650;
            else if (c.speed == 30)
                return 350;
            else if (c.speed == 40)
                return 250;
            else if (c.speed == 50)
                return 180;
            else if (c.speed == 60)
                return 100;
            else if (c.speed == 70)
                return 65;
            else if (c.speed == 80)
                return 40;
            else if (c.speed == 90)
                return 20;
            else if (c.speed == 100)
                return 1;
            else
                return 0;
        }

        public int getData()
        {
            Car c = new Car();
            c = d.getData();
            int speed = c.speed;
            return speed;
        }
        public void changeAxes(char key)
        {
            if (key == 'u')
            {
                if(y<=0 || (x<=324 && y<=47) || (x>=808 && y<=47) || ((360<x && x<742) && (y<=434 && y>=280)))
                {
                    
                }

                else
                {
                    y = y - 3;
                }
                    
            }
            else if (key == 'd')
            {
                if (((x>=391-200 && x<=741) && (y>=280-99 && y<=434-99)) || y>=703-99 ||(x<=372 && y>=659-99)||(x>=740 && y>=659-99))
                {
                    
                }
                else
                    y = y + 3;
            }
            else if (key == 'l')
            {
                if(x<=36 || (x<=324 && y<=47) || (x<=372 && y>=659) || ((x>=391 && x<=741) && (y>=230 && y<=434)))
                {

                }
                else
                    x = x-3;
            }
            else if (key == 'r')
            {
                if(x>=1131-139 || (x>=808-139 && y<=47) || (x>762-139 && y>=659) || ((x>=391-139 && x<=741-139) && (y>=230 && y<=434)))
                {

                }
                else
                    x = x+3;

                
            }
        }
        public void setKey(char c)
        {
            key = 'c';
        }
        public char getKey()
        {
            return key;
        }


        
    }
}
