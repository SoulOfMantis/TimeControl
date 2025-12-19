FROM gcc:latest as build

ADD ./TeamCity/Project1 /app/src

WORKDIR /app/build
RUN build -o myapp Source.cpp
CMD ["./myapp"]