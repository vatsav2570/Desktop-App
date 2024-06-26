import express from 'express';
import cors from 'cors';
import bodyParser from 'body-parser';
import fs from 'fs';
import path from 'path';

const app = express();
const PORT = 3002;
const dbFilePath = path.resolve(__dirname, '../db.json');

app.use(cors());
app.use(bodyParser.json());

// Ensure db.json file exists and is initialized properly
if (!fs.existsSync(dbFilePath)) {
    fs.writeFileSync(dbFilePath, JSON.stringify([]));
}

const loadSubmissions = (): any[] => {
    try {
        const data = fs.readFileSync(dbFilePath, 'utf-8');
        return JSON.parse(data);
    } catch (error) {
        console.error("Error reading or parsing db.json:", error);
        return [];
    }
};

const saveSubmissions = (submissions: any[]) => {
    fs.writeFileSync(dbFilePath, JSON.stringify(submissions, null, 2));
};

app.get('/ping', (req, res) => {
    res.send(true);
});

app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    const submission = { name, email, phone, github_link, stopwatch_time };
    const submissions = loadSubmissions();
    submissions.push(submission);
    saveSubmissions(submissions);
    res.send('Submission received');
});

app.get('/read', (req, res) => {
    const { index } = req.query;
    const submissions = loadSubmissions();
    const submission = submissions[parseInt(index as string, 10)];
    res.send(submission);
});

app.delete('/delete/:name', (req, res) => {
    const { name } = req.params; // Assuming the name is sent in the request body
    console.log(name);
    if (!name) {
        return res.status(400).send('Name parameter is required');
    }

    const submissions = loadSubmissions();
    const filteredSubmissions = submissions.filter((submission) => submission.name !== name);
    saveSubmissions(filteredSubmissions);
    res.send('Form submission(s) deleted successfully');
});


app.put('/edit', (req, res) => {
    const { id, name, email, phone, github_link, stopwatch_time } = req.body;
    const submissions = loadSubmissions();
    const updatedSubmissions = submissions.map((submission) =>
        submission.id === id ? { ...submission, name, email, phone, github_link, stopwatch_time } : submission
    );
    saveSubmissions(updatedSubmissions);
    res.send('Form submission updated successfully');
});

app.get('/search', (req, res) => {
    const { email } = req.query;
    const submissions = loadSubmissions();
    const foundSubmission = submissions.find((submission) => submission.email === email);
    if (foundSubmission) {
        res.send(foundSubmission);
    } else {
        res.status(404).send('Submission not found');
    }
});


app.listen(PORT, () => {
    console.log(`Server running on http://localhost:${PORT}`);
});
