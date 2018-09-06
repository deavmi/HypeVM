Distributed Resources
=====================

This document describes the various aspects of the HypeVM that can be distributed accross multiple nodes.

## Memory

We can make an abstraction model for the VM's memory by assigning an array of bytes of the whole memory so several networked nodes but accessed via the same interface, even with mixed models of locally stored bytes and remotely stored bytes.

## Registers

Registers, in a way similiar to the remote memory model, can also be local, remote or a mixed model of both models.

## Others

### Devices

Devices can be run remotely as they act on and react to the state of the Memory which mean they could be implemented on a remote side with remote memory access.