import sys

def SelfDescNumber(i):
    if all([i.count(str(idx)) == int(num) for idx, num in enumerate(i)]):
        return 1
    else:
        return 0
 
def main():
    with open(sys.argv[1], "r") as f:
        for line in f:
            print(SelfDescNumber(line.rstrip()))
 
if __name__ == '__main__':
    main()
