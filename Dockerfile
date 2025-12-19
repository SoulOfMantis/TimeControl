FROM gcc:latest

ADD ./TeamCity/Project1 /app/src

WORKDIR /app/build
RUN gcc -o myapp Source.cpp
CMD ["./myapp"]