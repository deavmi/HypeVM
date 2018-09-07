System overhaul
===============

Once we have local memory, devices and registers working as intended we may want to make things more modular by providing the HypeVM servers.

The structure will be as follows. You will run the HypeVM with a given configuration like such:

TODO: Fix me and finish me

````
[HypeVM server]

ipBind
portBind

[Memory servers]

listofServers
ips and ports
````

## HypeVM cparameters

`ipBind`

These are parameters to the machine config.

## Memory servers

These configure nodes to be used as storage nodes.

## Register servers

These configure servers to store registers.

## Execute servers

Yeah maybe implement this somehow.

## Devices

The new way that devices will be implemented is as follows:

The device server listens for incoming connections from the device clients (which are implemented by the client writing the device). The DeviceManager polls each of these client devicess after a machine cycle (or part of it if you see that whole loop as one cycle).

The configuration section

