# ElectroCraft Motor/Drive Interface Using a Serial Port, C#, .NET, and MVVM

This is a collection of C# code to communicate with ElectroCraft 
brand motors and drives, and get all that stuff to an MVVM .NET
application.

# Motivation

ElectroCraft just cannot produce a _simple_ interface control doc, 
one describing the messages between drives and the external world.

Mostly, ElectroCraft will say:

* "Take your drive control code."
* "Use the drive code development environment."
* "Use the debug interface to see what bits-n-bytes go back & forth."
* "Put the bits-n-bytes in your code."

That's crap.  Here's how to get around it.

# Assumptions 

* Assumes your axises are daisy-chained using CAN
* One drive is the CAN master
* Your serial port is connected to the CAN master
* The .NET SerialPort class is used
* Your application is follows a C#, Model View View Model pattern.

# Crafting Your ElectroCraft Drive Code

ElectroCraft's design studio is all about stitching together ElectroCraft
motion- and motor-control code with your custom control data.

Here's some tips.

## Make It Look Like IO Ports & Registers

Getting to your custom control data can be quite confusing.  There's 
an easy way to do it:

* Define your custom control data.
* Define the data as going in-to/out-of IO ports and registers _in the drive_.
* Assign _drive memory addresses_ to these ports and registers.

By doing that:

* Data is accessed by a unique combo of axis and memory address
* It's either a 32- or 16-bit data read/write.

## Make Your Drive Code React To Changes to Ports & Registers

Just like controlling a chip on a board.

## Dealing With Axis On/Off and Drive Reset Become Simple Instructions

And that's a simple exception to the rules; it's easy to handle.

# Take Advantage of What's Here to Structure Communications

There's two aggregate namespaces here.

## ECFundies

This namespace contains classes you're actually use.  Good thing
to keep in a seperate namespace.

## ECPutItTogether

This example put's it together.  

## Collaborators.txt Is Your Friend

This is a quick run-down of who's important to what in this system.

# Finally: Learn MVVM aka Model View View Model Pattern

Writing a .NET app following MVVM is best described as a cliff:

* Go to the edge of the cliff.
* Fall off the cliff.
* Climb back up.
* Learn a lot, going down and comping back up.

Microsoft has several tutorials on this subject.  Study 'em.

# License

MIT, as always.  Just gimme credit.

# Tools

Developed using Mono 5.10 and Microsoft Visuald Studio.

-30-
