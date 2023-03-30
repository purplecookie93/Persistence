using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string name; // the persons full name

        private DateTime birthDate; // the persons birthdate

        private double height; // the persons height in int

        private bool isMarried; // is the person married (true/false)

        private int noOfChildren; // number of children the person have


        public string Name 
        {
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
                else { throw new Exception("Der er opstået en fejl"); }
            }
            get { return name; }   

        } 

        public DateTime BirthDate 
        {
            set { 
                if(value >= new DateTime(1900, 1, 1)) { 
                birthDate = value; }
                else { throw new Exception("Der er opstået en fejl"); }
            }
            get { return birthDate; }
        }

        public double Height 
        {
            set
            {
                if (value >= 0)
                { height = value; }
                else { throw new Exception("Der er opstået en fejl"); }
            }
            get { return height; }
        }

        public bool IsMarried 
        {
            set { isMarried = value; }
            get { return isMarried; }
        }

        public int NoOfChildren 
        {
            set
            {
                if (value >= 0)
                { noOfChildren = value; }
                else {throw new Exception("Der er opstået en fejl"); }
            }
            get { return noOfChildren; }
        }
        public Person (string name, DateTime birthDate, double height, bool isMarried, int noOfChildren) 
        {
            Name = name; 
            BirthDate= birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
        }
        public Person(string name, DateTime birthDate, double height, bool isMarried) :
            this (name, birthDate, height, isMarried, 0)
        { }

        // MakeTitle() Laver den string der indsættes i tekstfilen og printes til consolvinduet 
        public string MakeTitle () 
        {
           return $"{ this.name};{ this.birthDate};{ this.height};{ this.isMarried};{ this.noOfChildren}"; 
        }
    }
}
