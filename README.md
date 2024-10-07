# Pool Table Timer Control

## Description

The **Pool Table Timer Control** is a custom Windows Forms control designed for managing and tracking the time spent on a pool (billiards) table. It allows you to set the player's name, the table title, and an hourly rate for calculating billing. The control provides an easy-to-use interface for starting, pausing, and stopping the timer, displaying the total time elapsed in hours, minutes, and seconds. Once the session ends, the control triggers an event to provide the total time played and fees incurred.

## Features

- **Track time**: Records and displays the time in `HH:MM:SS` format.
- **Start/Pause functionality**: Ability to start, pause, and resume the timer.
- **Calculate fees**: Automatically calculates fees based on an hourly rate.
- **Custom events**: Triggers an event when the session ends, passing details such as player name, table title, time played, and total fees.
- **User-friendly interface**: Displays player name, table title, and time elapsed.

## Usage

1. Add the `ctrlPoolTable` control to your Windows Forms application.
2. Set the **PlayerName**, **TableTitle**, and **HourlyRate** properties.
3. Start the session by clicking the "Start" button, and pause/stop it as needed.
4. On session completion, the control raises the `OnTableFinish` event, which provides:
   - Player name
   - Table title
   - Total time played
   - Fees calculated based on the hourly rate.

## Installation

1. Clone the repository or download the source files.
2. Add the `ctrlPoolTable` class to your Windows Forms project.
3. Add the control to your form through the designer or programmatically.
