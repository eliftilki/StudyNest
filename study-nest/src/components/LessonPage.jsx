import React from 'react';

const LessonPage = () => {
  // Örnek chapter verileri
  const chapters = [
    { id: 1, title: 'Chapter 1', videoUrl: 'url_to_video', content: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.' },
    { id: 2, title: 'Chapter 2', videoUrl: 'url_to_video', content: 'Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.' },
    { id: 3, title: 'Chapter 3', videoUrl: 'url_to_video', content: 'Nulla facilisi. Sed vehicula quam ut libero fringilla, id posuere felis ultrices.' }
  ];

  // Şu anki chapter'ı tutacak state
  const [currentChapter, setCurrentChapter] = React.useState(chapters[0]);

  // Sonraki chapter'a geçme fonksiyonu
  const handleNextChapter = () => {
    const currentIndex = chapters.findIndex(chapter => chapter.id === currentChapter.id);
    if (currentIndex < chapters.length - 1) {
      setCurrentChapter(chapters[currentIndex + 1]);
    }
  };

  return (
    <div className="lesson-page">
      <div className="chapter-list" style={{ width: '25%', float: 'left' }}>
        <h2>Chapters</h2>
        <ul>
          {chapters.map(chapter => (
            <li key={chapter.id}>
              <button onClick={() => setCurrentChapter(chapter)}>{chapter.title}</button>
            </li>
          ))}
        </ul>
      </div>
      <div className="lesson-content" style={{ width: '75%', float: 'left' }}>
        <div className="video-player">
          <iframe width="100%" height="400" src={currentChapter.videoUrl} title="Lesson Video" frameBorder="0" allowFullScreen></iframe>
        </div>
        <div className="text-content">
          <h2>{currentChapter.title}</h2>
          <p>{currentChapter.content}</p>
        </div>
        <div className="navigation-buttons">
          <button onClick={handleNextChapter}>Next Chapter</button>
        </div>
      </div>
    </div>
  );
};

export default LessonPage;
