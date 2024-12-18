# ApiRabbitMq
This project is a .NET Core application that leverages RabbitMQ for asynchronous communication and SQL Server as a relational database. The solution implements a RESTful API to interact with the system, offering a robust message processing flow while adhering to modern development practices like Clean Architecture, DDD, and SOLID principles.


## **Key Features**
- **REST API**: Interface to interact with the system, enabling operations like sending and querying messages.
- **RabbitMQ**: Used as a message broker to manage asynchronous communication and message queues.
- **SQL Server**: Database to store and query information related to processed messages.
- **Clean Architecture**: Modular structure that separates responsibilities, facilitates testing, and enhances code maintainability.
- **Dependency Injection**: Dependency management to promote decoupling and testability.
- **Best Practices**: Implementation of patterns like **DDD (Domain-Driven Design)** and **SOLID principles** to ensure clean and extensible code.

---

## **Technologies Used**
- **.NET Core 6.0 or later**
- **RabbitMQ**
- **SQL Server**
- **Entity Framework Core**
- **Swagger** (for API documentation)
- **Docker** (optional for container orchestration)

---

## **Features**
1. **Message Sending**:
   - The API exposes an endpoint for sending messages that are published to a RabbitMQ queue.
2. **Message Processing**:
   - A RabbitMQ consumer processes the published messages and persists the data in SQL Server.
3. **Data Querying**:
   - Endpoints allow querying of processed and stored messages.
4. **Logging and Monitoring**:
   - Logs are generated to track message flow and ensure system integrity.

---

## **How to Run Locally**

### **Prerequisites**
- Installed .NET Core SDK.
- Docker (optional, for running RabbitMQ and SQL Server in containers).

### **Steps to Run**
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-project.git
   ```

2. Configure the connection string for SQL Server and RabbitMQ in the `appsettings.json` file.

3. Run the command to start the application:
   ```bash
   dotnet run
   ```

4. Access Swagger to test the endpoints:
   ```
   http://localhost:5000/swagger
   ```

---

## **Contributions**
Contributions are welcome! Please submit **issues** or create **pull requests** to suggest improvements or fix bugs.

---
