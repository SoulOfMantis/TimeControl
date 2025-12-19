FROM gcc:latest

ADD ./TeamCity/Project1 /app/src

WORKDIR /app/build
RUN g++ -o myapp /app/src/Source.cpp
RUN g++ -o mytest /app/src/UnitTest1/UnitTest1.cpp
##CMD ["./myapp"]