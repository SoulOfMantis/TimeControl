FROM gcc:latest

ADD ./TeamCity/Project1 /app/src

WORKDIR /app/build
COPY /app/src /app/build
RUN g++ -o myapp Source.cpp
##CMD ["./myapp"]