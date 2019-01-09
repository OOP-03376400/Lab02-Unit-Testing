# Lab02-Unit-Testing

## Introduction to Digital ATM
This application behaves as a standard simple) ATM machine. It displays a user interface to guide and prompt selections and inputs, and it allows the user to view current balance, make a deposit, make a withdrawal, and exit the application. It prevents overdrafts and negative deposits.

## Visuals


## How to use
The application automatically launches a console window upon compile/run, and a menu of options is presented. Interaction requires only input of selections (1, 2, 3, or 4). Selecting 4 (exit) or making an invalid selection will end the session and display a session receipt. Each transaction type contains transaction-specific prompts for user inputs (ex: deposit asks for deposit amount), and each transaction ends with transaction details (transaction type, amount, and ending balance). Attempting to make a negative deposit or a withdrawal in excess of account balance will result in an appropriate error message and no change to the account balance (failed transactions also included in session receipt).

## Other details
Unit tests confirm that each transaction method produces correct transaction accounting and returns a transaction string to include in the final session receipt. Unit tests do not confirm input validation due to limitations on console input testing.

