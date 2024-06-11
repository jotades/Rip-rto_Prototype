Certainly! Below is a README file that you can use for your GitHub repository to explain the C# program you provided. 

---

# C# Inheritance Example: Road Characterization Blocks

This repository contains a C# program that demonstrates the concept of inheritance. The program models different characteristics of road blocks, including their morphology, crossing types, and traffic rules.

## Table of Contents
- [Introduction](#introduction)
- [Classes](#classes)
  - [Block](#block)
  - [MorphologyBlock](#morphologyblock)
  - [Cross](#cross)
  - [Rule](#rule)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction
This C# program illustrates the use of inheritance in object-oriented programming. The program defines a series of classes that represent different types of road blocks, inheriting properties and methods from parent classes. The main class `CaratterizationBlock` creates instances of these road blocks and prints their properties.

## Classes

### Block
The `Block` class represents the basic unit with an identification code.
- Properties:
  - `id_code`: The ID code of the block.
- Methods:
  - `display_BlockCode()`: Displays the block's code.

### MorphologyBlock
The `MorphologyBlock` class inherits from `Block` and adds properties related to the road's physical structure.
- Properties:
  - `n_Corsie`: Number of lanes (1 to 2).
  - `n_Carreggiate`: Number of carriageways (1 to 3).
  - `typeRoad`: Enum for the type of road (Straight, Curve, Roadbends, Highway).
- Methods:
  - `display_nCorsie()`: Displays the number of lanes and carriageways.

### Cross
The `Cross` class inherits from `MorphologyBlock` and adds properties related to different types of crossings.
- Properties:
  - `_none`, `_Tcross`, `_Xcross`, `_roundabout`, `_immission`: Boolean flags for various crossing types.
  - `typeCross`: Enum for the type of crossing (None, TCross, Xcross, Roundabout, Immission).

### Rule
The `Rule` class inherits from `Cross` and adds properties related to traffic rules.
- Properties:
  - `_stop`, `_priority`, `_trafficLight`: Boolean flags for traffic rules.
  - `LevelOfTraffic`: Enum for the level of traffic intensity (none, Medium, High).
- Constructor:
  - Initializes all properties from `Block`, `MorphologyBlock`, `Cross`, and `Rule`.

## Usage

To run the program:
1. Ensure you have a C# compiler installed.
2. Copy the code into a `.cs` file.
3. Compile and run the program using your C# compiler.

Example output:
```
Block: CODE: 1 | N.corsie: 1 | N.Carreggiate: 1 | TypeRoad: Curve | TypeCross: TCross | IntensityTrafficLevel none-medium-high: Medium | Stop-T/F: False | Priority-T/F: True | TrafficLight-T/F: True
Block: CODE: 2 | N.corsie: 2 | N.Carreggiate: 2 | TypeRoad: Straight | TypeCross: Roundabout | IntensityTrafficLevel none-medium-high: none | Stop-T/F: True | Priority-T/F: True | TrafficLight-T/F: False
```

## Contributing

Contributions are welcome! Please feel free to submit a pull request.

## License

This project is licensed under the MIT License.

---

This README file provides an overview of the program, explaining its structure and how to run it. Feel free to customize it further according to your needs.
