using linkedlistqueue;

Console.WriteLine("Hello World!");
LinkedListQueue linkedListQueue = new LinkedListQueue();
linkedListQueue.Enqueue(56);
linkedListQueue.Enqueue(30);
linkedListQueue.Enqueue(70);
linkedListQueue.Display();// this.top=this.top.next
linkedListQueue.Dequeue();
linkedListQueue.Dequeue();
linkedListQueue.Dequeue();
linkedListQueue.Display();
Console.ReadKey();