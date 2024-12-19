## Queues and Stacks

### StaticQueue
An interface for a generic static queue has been defined in IStaticQueue.</br>
It has been partially implemented in StaticQueue.cs</br>
Complete the code in StaticQueue.cs so that all the tests in TestStaticQueue.cs pass.</br>
It should be a circular queue.</br>
Write calling code in Program.cs.</br>
You should create at least two different Queues containing different types of data and test Queueing and Dequeueing items </br>

### StaticStack
An interface for a generic static stack has been defined in IStaticStack.</br>
Create a class StaticStack to implement IStaticStack</br>
Write a test class TestStaticQueue to throughly test the behaviour of your stack.</br>
Write calling code in Program.cs to test pushing and popping items </br>

### Use your StaticQueue and StaticStack to perform the following tasks
1: Write a program to determine if a  bracketed expression is valid. </br> 
For every opening bracket there must be a closing bracket and brackets must open/close in the correct sequence.  </br> 
e.g. ( ( ) ) is valid.  ( ) ( ( ) ) is valid. ( ( ) ) ) ( is invalid.  </br> 
You can solve by pushing the next symbol onto the stack if it is a (.  </br> 
When a ) is reached, compare with the top of the stack by Peeking.  </br> 
If the top of the stack is a ( you can pop it and move to the next symbol. 
If the stack is empty then you have a closing bracket with no opening bracket and need to throw an exception.</br> 
At the end of the expression there should be nothing left on the stack.</br> 

2: Use a queue to reverse the output from a stack</br>
To do this pop the stack items and enqueue them</br>
Then dequeue the queue items and push them to the stack</br>

3: Generate binary numbers from 1 to any given number, “n”, using a queue</br>
Return your result as a list of strings</br>
To do this enqueue "1"</br>
Then loop from 1 to n doing the following:</br> 
Dequeue and add the dequeued value to your list</br>
Append "0" to the dequeued value and then enqueue</br>
Append "1" to the dequeued value and then enqueue</br>

Write tests for the above</br>

### Extension
Make your queue and stack classes dynamic.</br> 
