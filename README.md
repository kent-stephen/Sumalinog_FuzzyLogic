# Sumalinog_FuzzyLogic

## Summary

This is a simple Fuzzy Logic System that deals with how fast a car should run with respect to the car in front of it with the help of the DotFuzzy library.
The following are the rules that are used to determine its speed:

1. IF (DISTANCE IS Close) AND (SPEED IS Slow)  THEN CARSPEED IS Slow
2. IF (DISTANCE IS Close) AND (SPEED IS Medium)  THEN CARSPEED IS Slow
3. IF (DISTANCE IS Close) AND (SPEED IS Fast)  THEN CARSPEED IS Medium
4. IF (DISTANCE IS Medium) AND (SPEED IS Slow)  THEN CARSPEED IS Medium
5. IF (DISTANCE IS Medium) AND (SPEED IS Medium)  THEN CARSPEED IS Medium
6. IF (DISTANCE IS Medium) AND (SPEED IS Fast)  THEN CARSPEED IS Fast
7. IF (DISTANCE IS Far) AND (SPEED IS Slow)  THEN CARSPEED IS Medium
8. IF (DISTANCE IS Far) AND (SPEED IS Medium)  THEN CARSPEED IS Fast
9. IF (DISTANCE IS Far) AND (SPEED IS Fast)  THEN CARSPEED IS Fast

## Project Image
![image](https://user-images.githubusercontent.com/95534475/207750826-c59b5269-6b9c-469e-9fe2-dd3f717af93a.png)

* Trackbar to set the values for speed and distance ranging 0 - 100
* Buttons to fuzzify input values and defuzzify to find the speed of the car
