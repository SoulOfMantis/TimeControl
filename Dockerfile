FROM gcc:latest

ADD ./TeamCity/Project1 /app/src

WORKDIR /app/build
RUN g++ -o myapp Source.cpp
CMD ["./myapp"]