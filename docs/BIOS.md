BIOS
====

It might make sense for the machine to load a predefined image and then run that which can then load everything else. Perhaps we can incorporate this into the machine's boot process somehow and then let the user swap out BIOSes for other ones that maybe do further initialization.

What we probably want to do is to have a configuration file for the virtual machine or one that can be called on the virtual machine to boot accordingly to it.

An example configuration file is shown below:

````
biosImage = "bios.img"

loadDevice "path/to/device/code.idk"
loadDevice "path/to/device/code.idk"
loadDevice "path/to/device/code.idk"
````

We want to set the first code to be put into memory and run via the `biosImage` directive and also set the configuration of the devices we want added to the DeviceManager.