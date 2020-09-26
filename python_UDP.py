import random
import socket

server_socket = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
server_socket.bind(('127.0.0.1', 8000))

while True:
    rand = random.randint(0, 10)
    message, address = server_socket.recvfrom(1024)
    #message = message.upper()
    print(message)