# 🏢 Enterprise Attendance System – C# (Windows Forms)

## 📌 Project Overview
This project was developed as the **final assignment** for the Advanced Programming course at **UPIITA-IPN**.  
It is a **desktop application in C#** designed to manage employee attendance and material requests in a company.  

The system integrates **GUI design, QR code scanning, color detection, database handling, and ticket printing** to simulate a real-world enterprise workflow.  

---

## ⚙️ Features
- **Employee Authentication:** Login with account number and department validation.  
- **Attendance Registration:** Employees scan their QR code for attendance tracking.  
- **Material Request:** Allows users to request materials, validating department permissions.  
- **Ticket Generation:** Automatically creates `.txt` tickets with employee data, operation details, date, and time.  
- **Database Handling:** Uses text files to manage employee data and transaction history.  
- **GUI:** Built with Windows Forms and styled with **MaterialSkin**.  
- **Image Processing:** Implemented with **OpenCvSharp** for color/QR detection and **ZXing.Net** for QR decoding.  

---

## 👨‍💻 My Contribution
This was a **team project (5 members)**.  
My specific role was focused on developing the **ticket printing module**:
- Implemented ticket generation with `StreamWriter` in `.txt` format.  
- Ensured proper error handling and notification pop-ups.  
- Integrated ticket creation with attendance and material request operations.  

---

## 🎯 Results
- Successfully tested with 5 departments (Administration, Finance, Gardening, Cleaning, Management).  
- Automated workflows for employee attendance and material requests.  
- Reliable **reporting and historical records** via generated tickets.  
- Demonstrated teamwork, modular programming, and integration of **GUI + database + computer vision** in a single solution.  

---

## 🛠️ Tech Stack
- **Language:** C# (Windows Forms)  
- **Libraries:** OpenCvSharp4, ZXing.Net, MaterialSkin  
- **Tools:** Visual Studio, .NET Framework  

---
