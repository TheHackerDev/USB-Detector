# USB-Detector
A Blue Team tool to help detect physical attacks using USB devices.

##What this tool does
* Detects USB storage device insert/remove
* (Optional) Logs event persistently
* Logs event to screen
* Emails event with details
* Works on Windows systems (running .NET 4.5)

##What it doesn't do
* Stop physical attacks or data removal
* Capture keystrokes on insert/remove
* Detect HID devices
* Work on Linux, Mac, *BSD

##Still to do
- [ ] Get the USB serial number
  * This is difficult because some methods of getting the serial number get a different "serial number" after the device has been reformatted.
- [ ] Allow for more email configuration use cases (i.e. an open authentication mail server)

============================
###Pull requests accepted