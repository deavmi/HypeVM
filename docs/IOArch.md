I/O Architecture
================

Devices are controlled via manipulating the values in their address space. The `DeviceManager` polls each device which causes said device to call the `poll()` method which is implemented by the device and does whatever the implementation says it should. Usually the device will check its address space for certain values at certain addresses and take whatever action it sees neccessary.