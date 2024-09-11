
PriorityQueue<string, int> hospitalQueue = new PriorityQueue<string, int>();


hospitalQueue.Enqueue("Patient A", 7);
hospitalQueue.Enqueue("Patient B", 9);
hospitalQueue.Enqueue("Patient C", 2);
hospitalQueue.Enqueue("Patient D", 8);
hospitalQueue.Enqueue("Patient E", 8);
hospitalQueue.Enqueue("Patient F", 233);
hospitalQueue.Enqueue("Patient G", 1);
hospitalQueue.Enqueue("Patient H", 2);
hospitalQueue.Enqueue("Patient I", 5);
hospitalQueue.Enqueue("Patient J", 6);
hospitalQueue.Enqueue("Patient K", 2);
hospitalQueue.Enqueue("Patient L", 8);
hospitalQueue.Enqueue("Patient M", 9);
hospitalQueue.Enqueue("Patient N", 4);
hospitalQueue.Enqueue("Patient O", 2);
hospitalQueue.Enqueue("Patient P", 9);
hospitalQueue.Enqueue("Patient Q", 66);
hospitalQueue.Enqueue("Patient R", 12356);
hospitalQueue.Enqueue("Patient S", 32);
hospitalQueue.Enqueue("Patient T", 21232);


Console.WriteLine("Attended patients according to priority:");

while (hospitalQueue.Count > 0)
{
    string patient = hospitalQueue.Dequeue();
    Console.WriteLine(patient);
}
