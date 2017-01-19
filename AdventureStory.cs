using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
     class AdventureStory
    {
       

        public void StartStory()
        {
            Console.WriteLine("You find your self in a strange, locked building, full of weird nosises what do you do?\n 'exit', explore',");
            string Story = Console.ReadLine();
          switch(Story)
            {
                case "exit":
                    Console.WriteLine("you leave building");
                    GetOut();
                    break;
                case "explore":
                    Console.WriteLine("you brave soul venture into the unknown");
                    StartExploring();
                    break;
                default:
                    Console.WriteLine("you stayed put and got eatten");
                    Console.ReadLine();
                    break;
                }

        }

        private void GetOut()
        {
            
                Console.WriteLine("Just as your about to leave you hear someone else calling for help \n What will you do?\n Do you go back and 'save them' or 'save yourself'?");
           string Person = Console.ReadLine();

            if (Person == "save them")
            {
                Console.WriteLine("You make your way to the sound of the cry for help \n as you near the cry for help you find a sight that stops your heart");
                Console.ReadLine();
                StartStory();
            }
            else if (Person == "save yourself")
            {

                Console.WriteLine("You descide to save yourself, you are a heartless person");
                Console.ReadLine();
                StartStory();
                
            }
            else
                Console.WriteLine("Wrong answer");
            {
                GetOut();
            }
                 
            







      }
            
        private void StartExploring()
        {
            Console.WriteLine("You enter the dark cold building \n As you make you way father in you see a strange light up ahead. \n Do you want to goto the source of light? yes or no");
            string Light = Console.ReadLine();
            if (Light== "yes")
            {
                Console.WriteLine(" you find the light and go to another world, Where you make a new home for yourself");
                Console.ReadLine();
            }
            else if(Light== "no")
            {
                Console.WriteLine("You keep walking in the dark building and then get lost and you die all alone and nobody knows what happened to you");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That wasn't a option you could CHOOSE!!!!!!!!!!!");
                Console.ReadLine();
                StartExploring();
            }






        }
      

        //public void RunStory()
        //{
        //      MyStory = StartStory();
        //        return 

        //    Console.ReadLine();

        //}

    } 
}
