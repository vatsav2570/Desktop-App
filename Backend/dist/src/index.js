"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const cors_1 = __importDefault(require("cors"));
const body_parser_1 = __importDefault(require("body-parser"));
const fs_1 = __importDefault(require("fs"));
const path_1 = __importDefault(require("path"));
const app = (0, express_1.default)();
const PORT = 3002;
const dbFilePath = path_1.default.resolve(__dirname, '../db.json');
app.use((0, cors_1.default)());
app.use(body_parser_1.default.json());
// Ensure db.json file exists and is initialized properly
if (!fs_1.default.existsSync(dbFilePath)) {
    fs_1.default.writeFileSync(dbFilePath, JSON.stringify([]));
}
const loadSubmissions = () => {
    try {
        const data = fs_1.default.readFileSync(dbFilePath, 'utf-8');
        return JSON.parse(data);
    }
    catch (error) {
        console.error("Error reading or parsing db.json:", error);
        return [];
    }
};
const saveSubmissions = (submissions) => {
    fs_1.default.writeFileSync(dbFilePath, JSON.stringify(submissions, null, 2));
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
    const submission = submissions[parseInt(index, 10)];
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
    const updatedSubmissions = submissions.map((submission) => submission.id === id ? Object.assign(Object.assign({}, submission), { name, email, phone, github_link, stopwatch_time }) : submission);
    saveSubmissions(updatedSubmissions);
    res.send('Form submission updated successfully');
});
app.get('/search', (req, res) => {
    const { email } = req.query;
    const submissions = loadSubmissions();
    const submission = submissions.find((s) => s.email === email);
    if (submission) {
        res.send(submission);
    }
    else {
        res.status(404).send('Submission not found');
    }
});
app.listen(PORT, () => {
    console.log(`Server running on http://localhost:${PORT}`);
});
