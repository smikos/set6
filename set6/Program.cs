using System;


public class ClientTests
{
   
    public void CanConnectToServer()
    {
        // Arrange
        Client client = new Client();

        // Act
        bool isConnected = client.ConnectToServer("192.168.1.1");

        // Assert
        Assert.True(isConnected);
    }

    
    public void CanSendDataToServer()
    {
        // Arrange
        Client client = new Client();

        // Act
        bool isDataSent = client.SendDataToServer("Hello, server!");

        // Assert
        Assert.True(isDataSent);
    }
}

public class Client
{
    public bool ConnectToServer(string serverIP)
    {
        // Реализация подключения к серверу
        return true;
    }

    public bool SendDataToServer(string data)
    {
        // Реализация отправки данных на сервер
        return true;
    }
}