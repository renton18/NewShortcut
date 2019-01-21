namespace 新ファイル名を指定して実行.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CommandDbContext : DbContext
    {
        // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'CommandDbContext' 
        // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
        // の '新ファイル名を指定して実行.Model.CommandDbContext' データベースを対象としています。 
        // 
        // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
        // アプリケーション構成ファイルで 'CommandDbContext' 接続文字列を変更してください。
        public CommandDbContext()
            : base("name=CommandDbContext")
        {
        }

        // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Command> Commands { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}