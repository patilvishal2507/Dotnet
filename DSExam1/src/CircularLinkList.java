import java.util.Scanner;

class Node {
    int data;
    Node next;

    Node(int data) 
    {
        this.data = data;
        next = null;
    }
}

public class CircularLinkList{

Node root,last;
 
void createLinkedListOdd()
{
    root=last=null;
}

void createLinkedListEven()
{
    root=last=null;
}
        
void createLinkedListNew()
{
    root=last=null;
}
  
void insertRightOdd(int data)
{
	 if(data%2 !=0) {
    Node n=new Node(data);
    if(root==null)
    {
        root=last=n;
        last.next=root;
        System.out.println("Inserted at Right\n");
    }
    else
    {
       last.next=n;
       last=n;
       last.next=root;
       System.out.println("Inserted at Right\n");
    }
	 }
	 else
	 {
		 System.out.println("Wrong Data !! Enter input ODD numbers only\n");
	 }
  }

void insertRightEven(int data)
{
	 if(data%2==0)
	 {
    Node n=new Node(data);
    if(root==null)
    {
        root=last=n;
        last.next=root;
        System.out.println("Inserted at Right\n");
    }
    else
    {
       last.next=n;
       last=n;
       last.next=root;
       System.out.println("Inserted at Right\n");
    }
	 }
	 else
	 {
		 System.out.println("Wrong Data !! Enter input EVEN numbers only\n");
	 }
  }


void printListOdd()
{
    if(root==null)
    {System.out.println("List Empty");
    }
    else
    {
        Node t;
        t=root;
        do
        {
            System.out.println(t.data);
            t=t.next;
        }  while(t!=root);
    }
} 
void printListEven()
{
    if(root==null)
    {System.out.println("List Empty");
    }
    else
    {
        Node t;
        t=root;
        do
        {
            System.out.println(t.data);
            t=t.next;
        }  while(t!=root);
    }
} 


	

void printList()
{
    if(root==null)
    {System.out.println("List Empty");
    }
    else
    {
        Node t;
        t=root;
        do
        {
            System.out.println(t.data);
            t=t.next;
        }  while(t!=root);
    }
}



public static void main(String args[]) {

	int ch,e;
	CircularLinkList obj=new  CircularLinkList();
	CircularLinkList obj2=new CircularLinkList();
	CircularLinkList obj3=new  CircularLinkList();
   Scanner in = new Scanner(System.in);
       obj.createLinkedListOdd();
       obj2.createLinkedListEven();
       obj3.createLinkedListNew();
       
    
       
       
       do
       {
            System.out.println("1.Insert Right for Odd list \n2.Print List for Odd list \n3.Inser Right List for Even \n4.Print list for Even \n5.Printlist\n0.Exit\n ");
            ch=in.nextInt();
            switch(ch)
            {
            
                    
                  case 1:	
                            System.out.println("Enter Data:");
                            e=in.nextInt();
                            obj.insertRightOdd(e);
                            
                            break;  
                            
             
                  case 2:
                            obj.printListOdd();
                            break;

                  case 3:	
	                        System.out.println("Enter Data:");
	                        e=in.nextInt();
	                        obj2.insertRightEven(e);
	                         
	                        break;

                  case 4:
	                        obj2.printListEven();
	                       
	                        break;
                  case 5:
                      System.out.println("---------------DoubleLinkedList-----------------");
                      obj.printList();
                      obj2.printList();
                           break;      
	                         
                  case 0:   System.out.println("Exiting ");
                  break;

                  default:
	                        System.out.println("Wrong option selected");
	                        break;
            }
       }while(ch!=0);
       in.close();
    }
	
}