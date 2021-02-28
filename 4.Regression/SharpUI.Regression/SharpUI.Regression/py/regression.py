import json
import time
import datetime

config = json.load(open("../reg.json"))

print(config)

for count in [3,2,1]:
	time.sleep(1)

	print(f"{count}")
	now = datetime.datetime.now()
	if now.second % 10 == 0:
		raise Exception("random error")

