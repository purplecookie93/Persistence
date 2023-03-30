using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;

namespace Persistens
{
    public class DataHandler
    {
        private string dataFileName;

        public string DataFileName 
        {
            get { return dataFileName; }
        }

        public DataHandler (string dataFileName)
        {
            this.dataFileName = dataFileName;
        }

        // Metoden skriver dataen til tekstfilen
        public void SavePerson (Person person)
        {
            StreamWriter writer = new StreamWriter(DataFileName);
            writer.Write(person.MakeTitle());
            writer.Close();
        }
        
        // Metoden læser dataen fra tekstfilen og retunere dataen og deler dem op. 
        public Person LoadPerson () 
        {
            StreamReader reader = new StreamReader(DataFileName);
            string line = reader.ReadLine();
            
            reader.Close();
            
            string[] array = line.Split(';');

            return new Person(array[0], DateTime.Parse(array[1]), double.Parse(array[2]), bool.Parse(array[3]), int.Parse(array[4]));

        }

        

        // Metode SavePersons() gemmer en datasamling i en tekstfil på hver deres linje 
        public void SavePersons(Person[] persons)
        {
            string data = "";

            foreach (Person person in persons) 
            {
                data += person.MakeTitle() + "\n";
            }
            StreamWriter writer = new StreamWriter(DataFileName);
            writer.Write(data);
            writer.Close();
        }

        public Person[] LoadPersons()
        {
            StreamReader reader = new StreamReader(DataFileName);
            string line = reader.ReadLine();

            Person[] persons = new Person[50];
            int i = 0;  

            while (line != null)
            {
                string[] array = line.Split(";");
                persons[i] = new Person(array[0], DateTime.Parse(array[1]), double.Parse(array[2]), bool.Parse(array[3]), int.Parse(array[4]));
                line = reader.ReadLine();
                i++;
            }
            reader.Close();

            return persons;
        } 
    }
}
