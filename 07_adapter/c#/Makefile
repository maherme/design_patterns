TARGET = Prog.exe
CC = mcs
SRC = *.cs

$(TARGET) : $(SRC)
	$(CC) -out:$(TARGET) $(SRC)

.PHONY : all
all: $(TARGET)

.PHONY : clean
clean:
	@rm -r $(TARGET)

.PHONY : run
run:
	@mono $(TARGET)
