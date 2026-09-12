import UnityPy
import os

original_cid = "1338004997867563"
new_cid = "71880669677692928"

src = r"C:\Users\cromo\Downloads\Piggy Hunt\piggy-hunt_Data\resources.assets"
output_dir = r"C:\Users\cromo\Downloads\Piggy Hunt\output"

os.makedirs(output_dir, exist_ok=True)

env = UnityPy.load(src)

found = False

for obj in env.objects:
    if obj.type.name != "TextAsset":
        continue

    data = obj.read()

    if original_cid in data.m_Script:
        print("Found CID in TextAsset")

        data.m_Script = data.m_Script.replace(
            original_cid,
            new_cid
        )

        obj.save_typetree(data)

        found = True
        break

if not found:
    print("CID was not found.")
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