using System;

namespace neo1
{
    class Program
    {
        static string[] list;
        static int?[] sortList;
        static int size =10;
        static int?[] fileList;
        static void Main(string[] args)
        {
            list =new string[size];
            fileList=new int?[size];
            list[0]="Yize";
             insert(0, "Neo");
            insert(1, "Andy");
            insert(0, "Hao");   
            // list = {"Hao", "Neo", "Andy"}
            Console.WriteLine("Suppose to be: (Hao, Neo, Andy, Yize)");
            Console.WriteLine($"Actually it is: ({string.Join(',',list)}) ");

            delete(0);
            delete(1); 

            Console.WriteLine("After deleted, Suppose to be: ( Neo, Yize)");
            Console.WriteLine($"Actually it is: ({string.Join(',',list)}) ");

            sortList =new int?[size];
            insertSortList(5);
            insertSortList(8);
            insertSortList(2);
            insertSortList(4);
            insertSortList(1);
            insertSortList(15);
            insertSortList(4);
            insertSortList(5);

            Console.WriteLine("After insert sort list, Suppose to be: ( 1, 2, 4, 5, 8)");
            Console.WriteLine($"Actually it is: ({string.Join(',', sortList)}) ");

        }
        static void insertSortList(int value){
            for (int i = 0; i <= size - 2; i++){
                if(sortList[i]==null){
                    sortList[i] = value;
                    break;
                } else if (sortList[i] >= value)
                { 
                   // sortList[i - 1] = value;
                    insertSortList(i,value);
                    break;
                
                }
            }
        }
            
          

        static void insert(int index, string value){
           
             for (int i = size-1; i >= index+1; i--)
            { 
                list[i] = list[i-1] ;
            }
             list[index] = value;
        }
        static void insertSortList( int index, int value){
           
             for (int i = size-1; i >= index+1; i--)
            { 
                sortList[i] = sortList[i-1] ;
            }
             sortList[index] = value;
        }
        static void findSortListSmart(int value)
        {
            if(value > size / 2)
            {
                if(value > size / 4)
                {
                
                }
            }else if(value > size / 0.5) {

            }
        }
        static void delete (int index){
            for (int i = index; i <= size-2; i++)
            {
                list[i] = list[i + 1];
                //list[index+1] = ;
            }
            list[size-1] = null;
        }
        


    }
}
