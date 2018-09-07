Initializtation
===============

This document describes how the VM is initialized.

## Load configuration

The first step to start the VM is to start `hypeVM` with an argument containing the filename of the configuration file you would like to use. This file is described below.

````
ipBind
portBind
````

### Virtual machine configuration

These parameters describe the parameters for the virtual machine.

1.  `ipBind`
2.  `portBind`
3.  `enableRedundancy`
    * If set to true then the MemoryManager and RegisterManager will store duplicates of their respective states on nodes.
4.  `initImage`
    * The path to the boot image which will be loaded into memory and execution of it will be started.

### Memory configuration

These parameters describe the memory parameters for the virtual machine.

1.  `memorySize`
    * Sets the machine's memory size.
2.  `memoryServers`
    * Configures the list of memory servers to be used. Depending on the memory size specified by the `memorySize` the MemoryManager will automatically configure the balancing of memory ranges accross the nodes listed by the `memoryServers` parameter.

### Register configuration

These parameters describe the register parameters for the virtual machine.

1.  `registerServers`
    * Configures the list of register servers to be used. Depending on the number of register server specified by the `registerServers` the RegisterManager will automatically configure the balancing of memory ranges accross the nodes.

### Execute configuration

This feature will be implemented at a later stage and will maybe allow multi-core dankness?

## Boot

Once the configuration file has been loaded and all the parameters setup then the machine will begin the following process described below.

1.  Start managers
    * This will start all the relevant clients such as the MemoryManager, RegisterManager and DeviceManager.
    1.  The MemoryManager will be started and will then connect to the specified memory servers.
    2.  The RegisterManager will be started and will then connect to the specified register servers.
    1.  **TODO:** The DeviceManager will be started and will wait for connections from device clients then connect to the specified memory servers.
2.  Load initialization image
    * After the system is setup then the initialization process begins by loading the image into memory and setting the correct registers to the corresponding values. After this the machine cycles then begin.