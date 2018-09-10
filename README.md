HypeVM Specification
====================

![Probably broken](https://ci.appveyor.com/api/projects/status/l8pp5jt56neousab?svg=true)

> The _**cool**_, _**flexible**_ and _**distributed**_ VM.

~Jaco Geldenhuys circa 1776

## What is _HypeVM_?

**HypeVM** is a project that aims at creating an implementation of a virtual machine for the HypeVM specification (described later in this document) with the added features of allowing the virtual machine to be distributed in terms of its various resources [mentioned here](DistributedVM.md).

It aims to create a fully functional general purpose virtual machine architecture that can be used by anyone for anything.

## HypeVM Architecture

The architecture of the HypeVM is as follows:

### Registers

There are general purpose registers which can be used for use and then there are ones which have an affect on things other than the state of memory.

#### General purpose

These are the general purpose registers. This means that their value has no meaning to the state of the machine other than the machine occuying a certain value in these registers.

Each of these registers is prefixed with the size (in bytes) they are. The following format is used `{size}s{name}` to name registers.

##### Byte-sized registers

1.  `bsA` - General purpose register byte-size `A`
2.  `bsB` - General purpose register byte-size `B`
3.  `bsC` - General purpose register byte-size `C`
4.  `bsD` - General purpose register byte-size `D`

##### Word-sized registers

1.  `ssA` - General purpose register word-size `A`
2.  `ssB` - General purpose register word-size `B`
3.  `ssC` - General purpose register word-size `C`
4.  `ssD` - General purpose register word-size `D`

#### Specific purpose

These are the registers of which changing their value has an effect on the machine in someway or another, other than just changing the state of a register as with the general purpose registers.

##### I/O registers

These registers are useful for determining information regarding the I/O address space used for system devices. They are listed below.

TODO: Finish description of these

1.  `ioStart`
2. `ioEnd`

##### Memory registers

These registers are useful for determining information regarding the memory of the virtual machine. They are listed below.

TODO: Finish description of these

1.  `memSize`

##### State registers

These registers are uesful for determining information regarding the state of the virtual machine. They are listed below.

TODO: Finish description of these

1.  `machineStatus`
    * **Name:** halted
    * **Size:** `signed_byte`
    * **Register ID:** `3`
    * **Description:** Holds a value that is checked before each machine cycle begins. If the value is `0` then the machine cycle goes ahead, however is the value is not zero then the machine will halt.
    **Notes:** The value of this register may soon have more meaning added to it per value hence we recommend that you use the value `1` to halt the machine as it will probably become the value required for such a task and the other non-zero values will have different meanings.

### Devices

Devices can be attatched to the machine to add extra (or much needed) functionality. A dedicated region of memory (an address space) is dedicated to all of the devices. The beginning and end addresses are stored in the special purpose registers `ioStart` and `ioEnd`.

TODO: Add an I/O address space, probably before the code space.

### Memory

TODO

### Instructions

The instruction set of the HypeMachine is something that will be undergoing many changes throughout its lifetime but for now we can list some of the instructions that will definately be in it.

1.  `halt`
    * **Name:** Halt
    * **Opcode:** `0`
    * **Description:** This instruction halts the machine resulting in it ending execution. It does this bye setting the `machineStatus` register to a non-zero value (`1` in this implementation).
    * **Arguments:** _None_
2.  TODO: Add more instructions

TODO: Add more instructions.