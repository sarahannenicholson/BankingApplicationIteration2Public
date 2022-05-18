# Banking Application Iteration 2

<br>

>This application was developed as a submission for a University assignment

---
 # Contents
 
 - Introduction
 - Requireements
 - Installation
 - Configuration
 - Maintainers
 - License

---
## Introduction

The purpose of this application is to allow users to Create, Read, Update and Edit Bank Users and accounts assigned to these users. 
This application also has the fucntionality to allow users to transfer, deposit and withdraw money from the selected users accounts either into another acocunt,
or into 'cash'.

<br>

The application was developed with the following functions as requirements:
- Customer CRUD
- Account CRUD
- Deposit/Withdraw/Transfer 'funds'
- Calculate/add interest
- Write/Read to serialised binary file

<br>

 In addition to the functions developed in iteration 1 of the project, which enables users to:
 - Set different rates for different account types
 - Set different rated for accounts for different user types
 - Incorpoates different fee perecentages based on user types/account types

---

## Requirements

No special requirements are needed to run this application

---

## Installation

This application was developed in VS code, currently has no executable and is only usable via code editor. To use this application please follow these steps:
- Download and save repo to prefered location (please note where you save the folder)
- In your chosen code editor, import the downloaded folder 
- After the folder has finished importing, you should see a list of all files and folders in the explorer window
- Use the application as you desire

---

## Configuration

This application uses a seralised binary file in order to store the "Account" and "User" infomation. These files are coded to work from the included "txt files" folder 
which is contained in the download. However, depending on your specific editor, sometimes it will default to reading files from a different location. If you find 
yourself having an error with this, please check the following portions of code:

```java
ReadTextFileCustomers()
ReadTextFileAccounts()
DeleteAccount()
DeleteCustomer()
UpdateAccount()
UpdateCustomer()
```
These are all located in the ``` Controller.cs ``` class, and should read as follows:

```java

"../../AllCustomers.txt"
"../../Coutput.txt"
"../../Coutput.txt.bac"

"../../AllAccounts.txt"
"../../Aoutput.txt"
"../../Aoutput.txt.bac"
```
These files relate to the following:
- All Customers main binary file
- Customer Output file
- Customer Output backup file
- All Accounts main binary file
- All Accounts Output file
- All Accounts backup file

Please make sure these files read as shown above in order for the application to use the inbult CRUD functionality properly.

---
## Maintainers

This application is no longer being maintained or worked on, and is likely to stay in its current state indefinitely.

---
## License

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)

To the extent possible under law, all rights have been waived in relation to copyright and related or neighboring rights to this work.
