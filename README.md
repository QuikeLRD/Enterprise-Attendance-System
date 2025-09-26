# Enterprise Attendance Registration System – C# (Windows Forms)

## Project Description
This project was developed as a **final project** for the Advanced Programming course.  
It is a **desktop application in C#** designed to manage employee attendance and material requests within a company.

The system integrates a **graphical user interface (GUI), QR code scanning, color detection, text file-based database management, and ticket generation**, simulating a real-world workflow.

---

## ⚙️ Features
- **Employee authentication:** Login using employee account number and department validation.
- **Attendance registration:** Employees register their entry by scanning a QR code.
- **Material requests:** Allows users to request materials, validating permissions based on their department.
- **Ticket generation:** Automatically creates `.txt` files with employee data, operation details, date, and time.
- **Database management:** Uses text files to store employee and transaction data.
- **Graphical interface:** Built with Windows Forms and styled using **MaterialSkin**.
- **Image processing:** Implemented with **OpenCvSharp** for color/QR detection and **ZXing.Net** for QR code decoding.

---

## My Contribution
This was a **team project (4 members)**.  
My specific role was to develop the **ticket printing module**:
- Implementation of ticket generation using `StreamWriter` in `.txt` format.
- Error handling and popup notifications.
- Integration of the ticket system with attendance and material request modules.

---

## Results
- Successfully tested with 5 departments (Administration, Finance, Gardening, Cleaning, Management).
- Automated attendance and material request processes.
- Generation of **reports and historical records** through tickets.

---

## 🛠️ Technologies Used
- **Language:** C# (Windows Forms)
- **Libraries:** OpenCvSharp4, ZXing.Net, MaterialSkin
- **Tools:** Visual Studio, .NET Framework

---

## 📂 Repository Structure
📁 EnterpriseAttendanceSystem  
┣ 📂 src/ # Main source code  
┣ 📂 data/ # Employee and transaction database (text files)  
┣ 📂 tickets/ # Generated tickets  
┗ README.md # Project documentation
