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
        }

        // setters

        public void UpdateColor()
        {
            if (this.speed <= 10f)
            {
                this.color = ConsoleColor.White;
            }
            else if (this.speed > 10f && this.speed < 100f)
            {
                this.color = ConsoleColor.Red;
            }
            else
            {
                this.color = ConsoleColor.White;
            }

        }

        public ConsoleColor GetColorBlue()
        {
            return this.color;
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
            UpdateColor();
        }
        // reset speed
        public void ResetSpeed()
        {
            this.speed = 0f;
            UpdateColor();
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
                this.angle = this.angle % 360;
                // TO DO: Angle has to be between 0 and 360 graden
            }
        }
        // Hit spiegeld het bal
        public void Hit()
        {
            this.angle = (180 - this.angle) % 360;
        }

        // Increases angle
        public void IncreaseSpeed(float speed)
        {
            this.speed += speed;
            UpdateColor();
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
