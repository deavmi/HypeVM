HypeVM Specification
====================

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

##### Informative registers

These registers hold useful values related to the current configuration of the machine.

TODO: Finish description of these

1.  `memBegin`
2.  `memEnd`

### Devices

Devices can be attatched to the machine to add extra (or much needed) functionality. A dedicated region of memory (an address space) is dedicated to all of the devices. The beginning and end addresses are stored in the special purpose registers `ioStart` and `ioEnd`.

TODO: Add an I/O address space, probably before the code space.

### Memory

TODO

### Instructions

The instruction set of the HypeMachine is something that will be undergoing many changes throughout its lifetime but for now we can list some of the instructions that will definately be in it.

1.  `halt`
    * **Name:** Halt
    * **Description:** This instruction halts the machine resulting in it ending execution.
    * **Arguments:** _None_

TODO: Add more instructions.