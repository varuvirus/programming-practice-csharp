//using System; 
//using System.Collections.Generic; 

//namespace ProgrammingPractice.LinkedLists
//{
//    public class Node
//    {
//        public Node next;
//        public int data;
//    }

//    public class LinkedList
//    {
//        private Node head;

//        public void printAllNodes()
//        {
//            Node current = head;
//            while (current != null)
//            {
//                Console.Write(current.data);
//                current = current.next;
//                if(current != null){
//                    Console.Write("->"); 
//                }
//                else
//                {
//                    Console.WriteLine(); 
//                }
//            }
//        }

//    public class LinkedListOperations
//    {
//        public void Start()
//        {
//            var root = Instantiate(5); 
//            PrintLinked List(root); 
//        }

//        public void AddLast(int data)
//        {
//            if (head == null)
//            {
//                head = new Node
//                {
//                    data = data,
//                    next = null
//                };
//            }
//            else
//            {
//                Node toAdd = new Node
//                {
//                    data = data
//                };

//                Node current = head;
//                while (current.next != null)
//                {
//                    current = current.next;
//                }

//                current.next = toAdd;
//            }
//        }
//    }



//    public class LinkedListOperations
//    {
//        public static void Start()
//        {
//            LinkedList myList1 = new LinkedList();
//            var randomNumberGenerator = new Random();

//            for (int i = 0; i < 10; i++)
//            {
//               myList1.AddLast(randomNumberGenerator.Next(100)); 
//            }

//            myList1.printAllNodes(); 
//        }        
//    }
//}