using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarriculumSingleton : MonoBehaviour
{
    public static CarriculumSingleton Instance;
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private int STEP = 0;
    public int getStep()
    {
        return STEP;
    }

    public string[] getDialogue()
    {
        return Dialogue;
    }

    public void stepUP()
    {
        if (STEP < Dialogue.Length)
        {
            STEP++;
        }

    }
    public void stepDOWN()
    {

        if (STEP > 0)
        {
            STEP--;
        }

    }
    // Start is called before the first frame update
    private string[] Dialogue = {
    "Hello my name is Quantu, I will be your quantum tutor, tap on the green arrow on the bottom to proceed",//0
        "Without further ado, lets begin!",//1
        "Before we talk about the magic of Quantum Computing, let's quickly go over how regular computers work",//2
        "Conventional computers are all around us. Even the device you are using right now is one such computer.",//3
        "All conventional computing systems have one thing in common.",//4
        "They represent logic through bits, two-state logical units.",//5
        "Also, I bet you didn't know I can transform into stuff!",//6
        "These two state logical units are called BITS and are implemented in the form of transistors.",//7
        "A bit can either have a state of 0",//8
        "OR 1",//9
        "This seemingly simple mechanism is what drives every computer in the modern world.",//10
        "Unfortunately, technology has reached the point where we have achieved the smallest possible transistor.",//11
        "Effectively handicapping us in terms of potential computational power.",//12
        "This issue can be resolved through the application of QUIBITS!",//13
        "Just like bits, Quibits can have a 0 state",//14
        "And a 1 state",//15
        "What makes Quibits special is that they have a third state referred to as a superposition",//16
        "Which can be thought of us as a compound state of 1 and 0 that occupies the space in between",//17
        "This gives us the ability to express complex logic, by using fewer logical units.",//18
        "Just this fact on its own can single-handedly revolutionize computing forever.",//19
        "But let's quickly explore how qubits are made.",//20
        "There are many ways to create a qubit, but we shall use one that best demonstrates the quantum phenomenon at play",//21
        "A phosphorous atom in a silicon crystal substrate!",//22
        "For now, let's focus on the phosphorus atom and more specifically it's electron",//23
        "Every electron has a property known as spin, dictated by its energy state",//24
        "An electron can have two spin states, spin up or spin down, respectively 0 and 1 from a computation point of view",//25
        "It is impossible to know for certain in which state an electron would be under regular conditions.",//26
        "By now it must've made an impression on you that every time you touch the screen, the electron changes it's state.",//27
        "This is a bit of quantum magic, it is impossible to know in what state the electron would be for sure, before a measurement has been taken.",//28
        "This comes with a little caveat tough, it is possible to force an electron into spin down state!",//29
        "This can be performed by removing all thermal energy in the surrounding",//30
        "This can be done by submerging the whole system in a cooling medium such as liquid hydrogen.",//31
        "Once we have all this set up, we only need to figure out how to actually switch the electron's state",//32
        "We can do this by hitting it with microwaves that have specific frequency, depending on the electric field of the electron.",//33
        "This way we can stimulate the electron to switch into the up state.",//34
        "And if we fiddle with the microwave pulse and for example, we cut it short, we can achieve a superposition between the up and down state",//35
        "It is important to remember that superposition is a virtual concept and cannot be observed in reality.",//36
        "Now you might wonder, what do the capabilities of qubits actually do for us?",//37
        "Without going into too much detail, the main strength of quantum computing is solving complex mathematical problems.",//38
        "For example, finding the prime factors of large numbers such as RSA-2048 which is crucial for the field of cryptography.",//39
        "Contemporary systems would take millions of years to find the primes, a quantum system could do it in hours.",//40
        "This is all possible due to quantum computers being able to perform special quantum algorithms, that paralelyze mathematical problems",//41
        "These are the basic principles of quantum computing!",//42
        "Now we are going to take a look into the underlying quantum phenomenon that enables the quantum computing.",//43
        "Let's get back to superposition and spin, as this is by far the most unconventional topic that we covered.",//44
        "The best way to visualize the quantum randomness that comes with spin properties is through the Stern gerlach experiment!",//45
        "Imagine that we have an electron gun that fires electrons through a non-uniform magnetic field that, what would happen?",//46
        "Common reason dictates that all electrons should have their angular momentum shifted in the same direction.",//47
        "But that's not what happens, seemingly randomly some electrons go up and some go down.",//48
        "This is because an electron's angular momentum is undetermined until a measurement has been performed.",//49
        "The magnet performs the measurement in this case.",//50
        "So having this in mind, it shouldn't come as a surprise that quantum systems often operate in a probabilistic nature.",//51
        "Let's look at the block sphere from earlier.",//52
        "The red arrow represents the spin state and is undetermined until a measurment is taken.",//53
        "And after the measurement is done we can use some mathematical magic to figure out what's state are we most likely to get.",//54
        "This is the underlying principle behind every quantum system.",//55
        "We must never forget that quantum phenomenon remains unexplained to this day, and mathematics only serve to describe it"//56
        };
}
