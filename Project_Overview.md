#Two parts: 
1. Hololens Client Development
2. RaspberryPi Server Development


#Basic workflow:

1. Hololens UWP App calls Web APIs provided by the RaspberryPi to send
a captured image to the RaspberryPi.

2. RaspberryPi receives the image and store it in a specific local directory and
then using that image for image processing. Finally, return the processing
result as a response back to the Hololens. 