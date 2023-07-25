from machine import Pin
import time

led = Pin("LED", Pin.OUT)

while True:
    led.on()  # a method instead of setting the value
    time.sleep(1)
    led.off() # turn it off again.
    time.sleep(1)