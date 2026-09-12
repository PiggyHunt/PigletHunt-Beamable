import UnityPy
import os

original_pid = "DE_1402027310012443"
new_pid = "DE_71880669677692929"

src = r"C:\Users\cromo\Downloads\Piggy Hunt\piggy-hunt_Data\resources.assets"
output_dir = r"C:\Users\cromo\Downloads\Piggy Hunt\output"

os.makedirs(output_dir, exist_ok=True)

env = UnityPy.load(src)

found = False

for obj in env.objects:
    if obj.type.name != "TextAsset":
        continue

    data = obj.read()

    if original_pid in data.m_Script:
        print("Found PID in TextAsset")

        data.m_Script = data.m_Script.replace(
            original_pid,
            new_pid
        )

        obj.save_typetree(data)

        found = True
        break

if not found:
    print("PID was not found.")
    raise SystemExit

print("Saving...")

env.save(output_dir)

output_file = os.path.join(output_dir, "resources.assets")

if os.path.exists(output_file):
    print("Successfully saved:")
    print(output_file)
    print("Size:", os.path.getsize(output_file), "bytes")
else:
    print("ERROR: Output file was not created.")
