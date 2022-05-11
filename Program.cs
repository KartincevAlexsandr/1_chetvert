using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args){

             ///генерируем массив
            string [] GenerateRandomArray(int count){
                string dictionaryABC = "0123456789abcdefghijklmnopqrstuvwxyz";
                Random rnd = new Random(); 
                List<string> listStering = new List<string>();
             
                for(var i = 0; i < count ; i++){
                    string str = "";
                    for(int j = 0; j < rnd.Next(1,10); j++){
                        str += dictionaryABC[rnd.Next(0,dictionaryABC.Length)];
                    }
                    Console.WriteLine(str);   
                    listStering.Add(str);
                }
              
                return listStering.ToArray();
            };


            Console.Write("Укажите массив, вводя значеия через запятую, или укажите число, для автоматической генерации:  ");
            string listEnter = Console.ReadLine();
            
            string [] listString = listEnter.Split(',');
            
            if(listString.Length == 1){
                listString = GenerateRandomArray(Convert.ToInt32(listString[0]));
                
            }

            List<string> newList= new List<string>();

            for(int i = 0 ; i< listString.Length; i++){
                if(listString[i].Length<=3){
                    newList.Add(listString[i]);
                }
            }


            for(int i = 0 ; i< newList.Count; i++){
                Console.WriteLine(newList[i]);
            }
            

        }
    }
}
