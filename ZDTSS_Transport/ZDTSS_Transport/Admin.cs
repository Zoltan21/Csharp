using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZDTSS_Transport
{
    public class AdminController
    {
        /// <summary>
        /// delete, add, modify commands
        /// </summary>
        public void manageCommand()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// showing a report about the current state of the processes, where are the cars
        /// </summary>
        public void viewReport()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// viewStatus all the commands and also possibility to special selection for each client
        /// </summary>
        public void viewAllCommands()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// manage==create, update , delete
        /// </summary>
        public void manageCars()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// manage==create, modify, delete
        /// </summary>
        public void manageRoutes()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// manage==create, modify, delete
        /// </summary>
        public void managePrices()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// add Client to admin, change info about client, delete client
        /// </summary>
        public void manageClients()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// each morning calculates the optimal solution from the point of viewStatus of capacity and "travellin salesman" for the day
        /// </summary>
        public void viewMorningJobs()
        {
            //pseudocode for to make it easier

            //1. step get the daily commands--use the date to select put everything into a list

            //2. separatization :  if inter command (inside of the the region) 1 day to collect them 2. day to deliver them
                                    //if not make 3 type of commands: 1:start to center-- 1. day, 2: center to ceter-- 2. day, 3: center to final 3.day
                                   //putting into a list each of them
            
            //3. 

            throw new System.NotImplementedException();
        }
    }
}
