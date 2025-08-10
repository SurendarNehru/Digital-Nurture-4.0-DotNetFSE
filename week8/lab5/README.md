# Git Hands-on: Cloning, Adding a File, and Pushing to Remote

## **Objective**

This exercise demonstrates:

* Cloning an existing repository from GitHub
* Adding a new file to the repository
* Committing changes locally
* Pushing updates to the remote repository

---

## **Steps Performed**

### **1. Clone the repository**

```bash
git clone https://github.com/SurendarNehru/GitCleanupLab.git
```

* Cloned the remote repository `GitCleanupLab` into the local folder.
* Verified that the repository contains existing files (`doc.tx`).

---

### **2. Navigate into the repository**

```bash
cd GitCleanupLab
```

Switched to the cloned repository’s directory.

---

### **3. Create a new file for the lab**

```bash
echo "This is a new file for the lab." > lab_file.txt
```

* Created `lab_file.txt` with the text *"This is a new file for the lab."*

---

### **4. Stage the file**

```bash
git add lab_file.txt
```

Marked `lab_file.txt` to be tracked and included in the next commit.

---

### **5. Commit the file**

```bash
git commit -m "add this txt file"
```

* Recorded the addition of `lab_file.txt` in the local repository.
* Commit ID: `d14d6d0`.

---

### **6. Check repository status**

```bash
git status
```

Showed that the branch was ahead of `origin/main` by 1 commit.

---

### **7. Push the commit to remote**

```bash
git push origin main
```

* Uploaded the local commit to the remote repository on GitHub.
* After pushing, the new file appeared in the remote repository.

---

## **Result on GitHub**

The repository `GitCleanupLab` now contains:

* `doc.tx` (existing file)
* `lab_file.txt` (newly added file containing the lab text)

---

## Output

<img width="1920" height="1080" alt="Screenshot 2025-08-10 224143" src="https://github.com/user-attachments/assets/7bc56622-9545-46ca-b543-414da37e2e50" />
<img width="1920" height="1080" alt="Screenshot 2025-08-10 224123" src="https://github.com/user-attachments/assets/aa9b4af7-9aa4-4c90-8e72-1cf6c8a5cbd3" />


## **Conclusion**

In this step, you:

* Cloned a remote repository
* Added a new file
* Committed the change locally
* Pushed the change to the remote
