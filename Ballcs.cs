using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenProject
{
    internal class Ballcs
    {
        private float speed = 3f;
        private int angle = 90;
        private int max = 360; // het maximaale graden
        private int min = 0; // het minimale graden
        ConsoleColor color = ConsoleColor.White;// iedere bal begint met de kleur wit
  
        //Constructor -> Ballcs ballcs =  new Ballcs
        public Ballcs(float speed, int angle, ConsoleColor color)
        {
            this.speed = 3f;
            this.angle = 90;
            this.color = ConsoleColor.White;// iedere bal begint met de kleur wit

            ////if (this.speed > 10f && this.speed < 100f)
            ////{
            ////    this.color = ConsoleColor.Red;
            ////}
            ////else if (this.speed < 10f)
            ////{
            ////    this.color = ConsoleColor.White;
            ////}
            ////else if (speed > 100f)
            ////{
            ////    this.color = ConsoleColor.White;
            ////}


        }

        // setters
        public void GetColorWhite()
        {
            if (this.speed < 10f)
            {
                this.color = ConsoleColor.White;
            }
        }
        public void GetColorRed()
        {
            if (this.speed > 10f && this.speed < 100f)
            {
                this.color = ConsoleColor.Red;
            }
        }
        public void GetColorBlue()
        {
            if (speed > 100f)
            {
                this.color = ConsoleColor.White;
            }
        }
        // Decreases speed 
        public void DecreaseSpeed(float speed)
        {
            float newSpeed = this.speed;
            newSpeed -= speed;
            if(newSpeed > 0f)
            {
                this.speed = newSpeed;
            }
        }
        // reset speed
        public void ResetSpeed()
        {
            this.speed = 0f;
        }
        public void IncreaseAngle(int angle)
        {
            this.angle += angle;
        }
        // Decreases angle 
        public void DecreaseAngle(int angle)
        {
            int newAngle = this.angle;
            newAngle -= angle;
            if (newAngle > 0f)
            {
                this.angle = newAngle;
            }
        }


        // Increases angle
        public void IncreaseSpeed(float speed)
        {
            this.speed += speed;
        }
        // getters
        public float GetBalSpeed()
        {
            return this.speed;
        }

        public int GetBalAngle()
        {
            return this.angle;
        }

        public ConsoleColor GetBalColor()
        {
            return this.color;
        }

    }
}
