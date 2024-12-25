# Synchronization with Windows Kernel Objects

## Homework 12

This repository contains solutions for the 12th homework assignment on synchronization using Windows kernel objects.

---

## Homework Tasks

### **Task 1**
Study the basic constructions and concepts discussed in the lesson.

### **Task 2**
Transform the event-blocking example to use automatic processing instead of manual handling.

[Link to the project](https://github.com/yanamak89/ThreadSync/tree/main/EventBlockingAutomationApp)

### **Task 3**
Create a program that can only be run as a single instance (using a named `Mutex`).

[Link to the project](https://github.com/yanamak89/ThreadSync/tree/main/SingleInstanceApp)

### **Task 4**
Visit the [MSDN website](https://learn.microsoft.com). Using the search functionality, independently find and study documentation for each example discussed in the lesson. Save the links and provide a short description of each resource.

### **Task 5**
Create a `Semaphore` that controls access to a resource from multiple threads. Organize orderly output of information about access to a special `.log` file.

[Link to the project](https://github.com/yanamak89/ThreadSync/tree/main/SemaphoreExample)

---

## Recommended Resources

- [Mutex on MSDN](https://learn.microsoft.com/en-us/windows/win32/sync/mutex-objects)
- [Semaphore on MSDN](https://learn.microsoft.com/en-us/windows/win32/sync/semaphore-objects)
- [Event Handling on MSDN](https://learn.microsoft.com/en-us/windows/win32/sync/event-objects)

---

## How to Run

1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Open the solution file in your IDE (e.g., Visual Studio).
3. Build and run the project.

---

## Examples

### Example 1: Event Handling
Demonstrates the use of automatic and manual events for synchronization.

### Example 2: Named Mutex
Ensures that only a single instance of the program is running at a time.

### Example 3: Semaphore Logging
Manages access to a resource and logs activity in an orderly manner.

---

## Author
**Yana Makogon**

For any inquiries, please reach out via GitHub or email.
