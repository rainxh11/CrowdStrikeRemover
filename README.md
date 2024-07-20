# CrowdStrike Faulty Driver Remover

Bootable ISO file that automatically finds the faulty CrowdStrike drivers in all system drives and removes them

# How does it work:

Bootable WinPE ISO with custom C# executable that runs on WinPE startup,

which then deletes any driver files that matches the `C-00000291*.sys` file name.

# How to use:

1. Download the [ISO File](https://github.com/rainxh11/CrowdStrikeRemover/releases/download/latest/FixCrowdStrike_PE.iso)
2. Download an ISO to USB burning tool like [Rufus](https://github.com/pbatard/rufus/releases/download/v4.5/rufus-4.5.exe)
3. Select and burn `FixCrowdStrike_PE.iso`

![](https://github.com/user-attachments/assets/6bebeb7a-5eb4-47c9-9f6d-58c201f3af8d)

4. Boot the system with the USB Stick
5. Wait for the Removal Tool to finish and the problematic drivers should be removed

https://github.com/user-attachments/assets/f1414d53-1f8e-448a-bf96-d82150df6a90
