# Gym Management (Gestion de Salle de Sport)

A desktop application written in **VB.NET** (Windows Forms) to manage a gym. It helps the manager keep track of members, staff, sports activities, class schedules and subscriptions. All data is saved in text files, so nothing is lost when the program is closed.

## Features

### Home
A simple start screen with a welcome message and six buttons, one for each module. Only one window can be open at a time to avoid errors.

### Members (Abonnés)
- Add, edit and delete members
- Stored information: name, date of birth, CIN, address, phone, history (notes)
- Checks before saving:
  - name and surname are filled in
  - CIN has 8 digits and starts with `0` or `1`
  - no duplicate CIN
  - age of at least 15
  - valid phone number

### Staff (Personnel)
- Add, edit and delete employees
- Stored information: name, CIN, phone, role (Manager, Coach, Nutritionist, Receptionist, Technician), salary, specialty, hiring date, active or not
- The specialty field is enabled only for coaches and nutritionists
- Checks: salary is a positive number, a role is selected, and a specialty is given for coaches and nutritionists

### Activities
Activities are organized in three tabs:
- **Cardio:** bike, elliptical, treadmill, rowing machine, stepper
- **Strength training:** weight training, core, abs, dumbbells
- **Group classes:** dance, yoga, pilates, stretching, zumba (with an assigned coach)

### Schedules (Plannings)
- Calendar to pick a date
- Table showing the classes of the selected day
- Add, edit and delete a class: date, activity, coach, start and end time

### Subscriptions (Abonnements)
- Manage member subscriptions and payments

## Data storage

Data is stored in plain text files:

| File | Content |
|------|---------|
| `abonnes.txt` | Members |
| `membres.txt` | Staff |
| `activites.txt` | Activities |
| `plannings.txt` | Class schedules |
| `abonnements.txt` | Subscriptions and payments |

> The files in this repository contain test data only.

## Design choices

- Large buttons that are easy to click
- Blue and grey colors for a sporty, professional look
-
