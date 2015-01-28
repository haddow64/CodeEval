import sys
 
def parse(s):
    distances = []
    points = s.split(";")
	
    for p in points:
        point_info = p.strip().split(",")
        if len(point_info) != 2:
            continue
 
        distances.append(int(point_info[1]))
 
    distances = sorted(distances)
    return distances
 
 
def road_trip(s):
    result = []
    distances = parse(s)
 
    result.append(str(distances[0]))
    for i in range(0, len(distances) - 1):
        result.append(str(distances[i + 1] - distances[i]))
 
    return ",".join(result)
 
 
def main():
    with open(sys.argv[1], "r") as f:
        for line in f:
            print(road_trip(line.rstrip()))
 
 
if __name__ == "__main__":
    main()