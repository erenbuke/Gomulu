import json
import urllib.request
import threading
import datetime

alarm_state_counter = 0


def set_light(light_level):
    print("light level: ", light_level)
    # todo


def calculate_light_state(alarm_info, method_state_counter=None):

    if method_state_counter is None:
        method_state_counter = alarm_state_counter

    now = datetime.datetime.now()
    now = now.replace(month=1, microsecond=0, day=1)

    alarm_time = datetime.datetime.now()
    alarm_time = alarm_time.replace(month=1, hour=alarm_info[0], minute=alarm_info[1], second=0, microsecond=0, day=1)

    if alarm_time < now:
        alarm_time += datetime.timedelta(days=1)

    time_difference = alarm_time - now
    time_difference_minutes = time_difference.seconds / 60

    if time_difference_minutes > alarm_info[2]:
        set_light(0)
    else:
        set_light((alarm_info[2] - time_difference_minutes) * 100 / alarm_info[2])

    if method_state_counter == alarm_state_counter:
        threading.Timer(1, calculate_light_state, [alarm_info, method_state_counter]).start()


def fetch_alarm_info(alarm_state, previous_state=None):
    response_body = json.load(
        urllib.request.urlopen("https://api.thingspeak.com/channels/1587340/feeds/last.json?api_key"
                               "=M2T80BJ533UVAQS0"))
    alarm_state.clear()
    alarm_state.append(int(response_body["field1"]))
    alarm_state.append(int(response_body["field2"]))
    alarm_state.append(int(response_body["field3"]))
    if previous_state is None:
        previous_state = alarm_state[:]
    else:
        if previous_state != alarm_state:
            previous_state = alarm_state[:]
            print("alarm state changed")
            global alarm_state_counter
            alarm_state_counter += 1
            calculate_light_state(alarm_state)
    print("in callback: ", alarm_state)
    threading.Timer(10., fetch_alarm_info, [alarm_state, previous_state]).start()


def write_alarm_info(alarm_hour, alarm_minute, start_before):
    urllib.request.urlopen(f"https://api.thingspeak.com/update?api_key=HC4WDU6WBMSPIWKS"
                           f"&field1={alarm_hour}&field2={alarm_minute}&field3={start_before}")


if __name__ == '__main__':
    # write_alarm_info(19, 23, 40)
    alarm_info = []
    fetch_alarm_info(alarm_info)
    calculate_light_state(alarm_info)
