**Assignment 6 – Kafka Chat Application using .NET and Apache Kafka**

**Student:** Surendar N

**Week:** 6

**Assignment:** Build a chat application using Apache Kafka and .NET C# to demonstrate real-time message streaming with Producer and Consumer components.
---
**Objectives**

Understand the architecture and working of Apache Kafka including how it handles real-time data streams.

Learn about Kafka core components such as brokers, topics, partitions, producers, and consumers.

Gain hands-on experience installing and configuring Kafka on a Windows machine using Zookeeper.

Learn how to integrate Kafka into .NET applications using the Confluent.Kafka NuGet package.

Understand how to create a producer that sends messages to a Kafka topic and a consumer that listens to and receives those messages.

Learn how to create, list, and manage Kafka topics using command-line tools.

Learn to structure real-time communication in a decoupled architecture using Kafka as the message broker.

Test and debug the flow of chat messages from sender to receiver using terminal output.

Understand the concept of event-driven systems and their practical usage in microservices and messaging applications.

---
**Tools Used**

Operating System: Windows 10
Editor: Visual Studio Code
.NET SDK Version: .NET 9 Preview
Kafka Version: Kafka 3.9.0 (Scala 2.13)
Kafka Library: Confluent.Kafka NuGet Package
Terminal: Windows PowerShell

---

**Steps Performed**

**Step 1: Installed Java 17 (JDK)**

* Installed Java 17 using Temurin (Adoptium MSI installer)
* Set JAVA\_HOME and updated system Path variable
* Verified installation using `java -version`

**Step 2: Downloaded and Extracted Kafka**

* Downloaded kafka\_2.13-3.7.0.tgz from the official Kafka website
* Extracted the archive and placed it in `C:\kafka\kafka_2.13-3.7.0`

**Step 3: Started Zookeeper and Kafka Broker**

* Ran Zookeeper using:
  `.\bin\windows\zookeeper-server-start.bat .\config\zookeeper.properties`
* Ran Kafka server using:
  `.\bin\windows\kafka-server-start.bat .\config\server.properties`

**Step 4: Created Kafka Topic**

* Used command to create topic `chat-topic`:
  `.\bin\windows\kafka-topics.bat --create --topic chat-topic --bootstrap-server localhost:9092 --partitions 1 --replication-factor 1`

**Step 5: Created .NET Console Producer App (Sender)**

* Created a new console app using: `dotnet new console -n KafkaSender`
* Installed the Confluent.Kafka package: `dotnet add package Confluent.Kafka`
* Implemented sender logic to type and send messages to Kafka topic `chat-topic`
* Used `ProduceAsync()` method to send messages

**Step 6: Created .NET Console Consumer App (Receiver)**

* Created another console app: `dotnet new console -n KafkaReceiver`
* Installed the same Kafka package
* Implemented logic to subscribe to the `chat-topic` and continuously receive messages
* Displayed received messages in the terminal

---

**Output**

<img width="1920" height="1080" alt="Screenshot 2025-07-19 112455" src="https://github.com/user-attachments/assets/7157c3e7-d1ed-4f24-9b74-68485db7d9e3" />
<img width="1920" height="1080" alt="Screenshot 2025-07-19 112513" src="https://github.com/user-attachments/assets/0cd98e44-f16f-4483-a165-28d4492b14c2" />
<img width="1920" height="1080" alt="Screenshot 2025-07-19 112527" src="https://github.com/user-attachments/assets/3b4f873d-80c3-44b7-8fc4-5e266a5e6e1f" />
Sender:
<img width="1920" height="1080" alt="Screenshot 2025-07-19 112336" src="https://github.com/user-attachments/assets/080de7ff-cf29-4d99-acd9-ebce02acb22c" />
Receiver:
<img width="1920" height="1080" alt="Screenshot 2025-07-19 112353" src="https://github.com/user-attachments/assets/db16afd7-e35f-4ae5-9c8a-602c8df18ef8" />

---

**Conclusion:**

Successfully created a real-time chat system using Apache Kafka and .NET C#. Understood the complete pipeline from Kafka setup to message streaming using Producer and Consumer console applications. Tested communication flow by simulating sender and receiver in separate terminals. This lab introduced essential concepts of event-driven architecture and real-time messaging in a distributed system.

