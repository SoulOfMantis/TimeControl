FROM gcc:latest

ADD ./TeamCity/Project1 /app/src

WORKDIR /app/build
COPY /app/src /app/build
RUN g++ -o myapp Source.cpp
RUN g++ -o mytest UnitTest1.cpp
##CMD ["./myapp"]